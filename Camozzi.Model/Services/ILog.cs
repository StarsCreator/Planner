﻿using System;

namespace Camozzi.Model.Services
{
    public interface ILog
    {

        void Error(string text, Exception ex);
    }
}
