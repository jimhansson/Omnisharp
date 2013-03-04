﻿namespace OmniSharp.Requests
{
    public abstract class Request
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public string Buffer { get; set; }
        public string FileName { get; set; }
    }
}
