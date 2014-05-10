﻿/*  
 * Papercut
 *
 *  Copyright © 2008 - 2012 Ken Robertson
 *  Copyright © 2013 - 2014 Jaben Cargman
 *  
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *  
 */

namespace Papercut.Helpers
{
    using System;

    using Caliburn.Micro;

    using Serilog;

    public class CalburnSerilogBridge : ILog
    {
        readonly Lazy<ILogger> _logger;

        public CalburnSerilogBridge(Lazy<ILogger> logger)
        {
            _logger = logger;
        }

        public void Info(string format, params object[] args)
        {
            _logger.Value.Debug(format, args);
        }

        public void Warn(string format, params object[] args)
        {
            _logger.Value.Warning(format, args);
        }

        public void Error(Exception exception)
        {
            _logger.Value.Error(exception, "Exception Logged");
        }
    }
}