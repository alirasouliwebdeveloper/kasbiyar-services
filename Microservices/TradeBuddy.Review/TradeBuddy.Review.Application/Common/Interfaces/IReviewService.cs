﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBuddy.Review.Application.Common.Interfaces
{
    public interface IReviewService
    {
        /// <summary>
        /// متدی برای پردازش پیام و پاسخ به آن.
        /// </summary>
        /// <param name="message">پیام ورودی</param>
        /// <returns>پاسخ به پیام</returns>
        Task<string> ProcessMessageAsync(string message);
    }
}
