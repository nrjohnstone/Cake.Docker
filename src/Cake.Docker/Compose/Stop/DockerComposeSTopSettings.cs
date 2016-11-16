﻿namespace Cake.Docker
{
    /// <summary>
    /// Settings for docker build.
    /// </summary>
    public sealed class DockerComposeStopSettings: AutoToolSettings
    {
        /// <summary>
        /// Specify a shutdown timeout in seconds (default: 10).
        /// </summary>
        public bool Timeout { get; set; }
    }
}
