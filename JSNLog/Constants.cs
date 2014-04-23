﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JSNLog.Infrastructure;
using JSNLog.ValueInfos;

namespace JSNLog
{
    public class Constants
    {
        public const string PackageName = "JSNLog";
        public const string ContextItemRequestIdName = "__JSNLog_RequestId";
        public const string HttpHeaderRequestIdName = "JSNLog-RequestId";
        public const string ConfigRootName = "jsnlog";
        public const string RegexBool = "^(true|false)$";
        public const string RegexPositiveInteger = "^[0-9]+$";
        public const string RegexIntegerGreaterZero = "^[1-9][0-9]*$";
        public const string RegexUrl = @"^[ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\-._~:/?#[\]@!$&'()*+,;=]+$";
        public const char AppenderNameSeparator = ';';
        public const string RootLoggerNameServerSide = "ClientRoot"; // Cannot use empty logger name server side, so use this instead.
        public const string JSNLogInternalErrorLoggerName = "JSNLogInternalError"; // Used when logging internal errors to Common.Logging

        // There is no RegexLevels, because that regex gets generated by a method in LevelUtils

        public const string JsLogObjectName = "JL";
        public const string JsLogObjectClientIpOption = "clientIP";
        public const string JsLogObjectRequestIdOption = "requestId";
        public const string JsLoggerAppendersOption = "appenders";
        public const string JsLoggerVariable = "logger";
        public const string JsAppenderVariablePrefix = "a";

        public enum Level
        {
            ALL = -2147483648,
            TRACE = 1000,
            DEBUG = 2000,
            INFO = 3000,
            WARN = 4000,
            ERROR = 5000,
            FATAL = 6000,
            OFF = 2147483647
        }

        public enum OrderNbr
        {
            Assembly,
            AjaxAppender,
            ConsoleAppender,
            Logger
        }

        public const string TagAssembly = "assembly";
        public const string TagAjaxAppender = "ajaxAppender";
        public const string TagConsoleAppender = "consoleAppender";
        public const string TagLogger = "logger";

        public static readonly string AttributeNameBufferSize = "bufferSize";
        public static readonly string AttributeNameSendWithBufferLevel = "sendWithBufferLevel";
        public static readonly string AttributeNameStoreInBufferLevel = "storeInBufferLevel";
        public static readonly string AttributeNameLevel = "level";

        public static readonly Level DefaultAppenderLevel = Level.TRACE;

        public static readonly IEnumerable<AttributeInfo> JSNLogAttributes =
            new[] {
                new AttributeInfo("enabled", new BoolValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo("maxMessages", new PositiveIntegerValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo("serverSideLogger", null, AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("serverSideLevel", new LevelValue(), AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("serverSideMessageFormat", null, AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("productionLibraryPath", null, AttributeInfo.AttributeValidityEnum.NoOption)
            };

        public static readonly IEnumerable<AttributeInfo> AssemblyAttributes =
            new[] {
                new AttributeInfo("name", null, AttributeInfo.AttributeValidityEnum.NoOption)
            };

        public static readonly IEnumerable<AttributeInfo> FilterAttributes =
            new[] {
                new AttributeInfo(AttributeNameLevel, new LevelValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo("ipRegex", null, AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo("userAgentRegex", null, AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo("disallow", null, AttributeInfo.AttributeValidityEnum.OptionalOption)
            };

        public static readonly IEnumerable<AttributeInfo> LoggerAttributes =
            FilterAttributes.Union(
            new[] {
                new AttributeInfo("name", null, AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("appenders", null, AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("regex", null, AttributeInfo.AttributeValidityEnum.OptionalOption, subTagName: "onceOnly")
            });

        public static readonly IEnumerable<AttributeInfo> AppenderAttributes =
            FilterAttributes.Union(
            new[] {
                new AttributeInfo("name", null, AttributeInfo.AttributeValidityEnum.NoOption),
                new AttributeInfo("batchSize", new PositiveIntegerValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo(AttributeNameSendWithBufferLevel, new LevelValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo(AttributeNameStoreInBufferLevel, new LevelValue(), AttributeInfo.AttributeValidityEnum.OptionalOption),
                new AttributeInfo(AttributeNameBufferSize, new PositiveIntegerValue(), AttributeInfo.AttributeValidityEnum.OptionalOption)
            });

        public static readonly IEnumerable<AttributeInfo> AjaxAppenderAttributes =
            AppenderAttributes.Union(
            new[] {
                new AttributeInfo("url", new UrlValue(), AttributeInfo.AttributeValidityEnum.OptionalOption)
            });

        public static readonly IEnumerable<AttributeInfo> ConsoleAppenderAttributes =
            AppenderAttributes;
    }
}
