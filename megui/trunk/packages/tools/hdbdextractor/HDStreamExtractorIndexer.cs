﻿// ****************************************************************************
// 
// Copyright (C) 2005-2009  Doom9 & al
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// 
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using MeGUI.core.details;
using MeGUI.core.util;

namespace MeGUI
{
    public class HDStreamExtractorIndexer: CommandlineJobProcessor<HDStreamsExJob>
    {
        public static readonly JobProcessorFactory Factory =
            new JobProcessorFactory(new ProcessorFactory(init), "HDStreamExtIndexer");

        private static IJobProcessor init(MainForm mf, Job j)
        {
            if (j is HDStreamsExJob) return new HDStreamExtractorIndexer(mf.Settings.EAC3toPath);
            return null;
        }

        private string lastLine;

        public HDStreamExtractorIndexer(string executablePath)
        {
            this.executable = executablePath;
            lastLine = "";
        }

        /// <summary>
        /// gets the completion percentage
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private decimal? getPercentage(string line)
        {
            try
            {
                if (Regex.IsMatch(line, "^progress: [0-9]{1,3}%$", RegexOptions.Compiled))
                {
                    int pct = Int32.Parse(Regex.Match(line, "[0-9]{1,3}").Value);
                    return pct;
                }
                else return null;
            }
            catch (Exception e)
            {
                log.LogValue("Exception in getPercentage(" + line + ") ", e, ImageType.Warning);
                return null;
            }
        }

        public override void ProcessLine(string line, StreamType stream)
        {
            su.PercentageDoneExact = getPercentage(line);
            su.Status = "Extract Tracks...";
            lastLine = line;
        }

        protected override string Commandline
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (job.InputType == 1) // Folder as Inpput
                {
                    sb.Append(string.Format("\"{0}\" {1}) {2}", job.Input, job.FeatureNb, job.Args + " -progressnumbers"));
                }
                else
                {
                    sb.Append(string.Format("\"{0}\" {1}", job.Input, job.Args + " -progressnumbers"));
                }

                return sb.ToString();
            }
        }
    }
}
