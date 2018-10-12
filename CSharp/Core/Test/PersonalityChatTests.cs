﻿// 
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
// 
// Microsoft Bot Framework: http://botframework.com
// 
// Personality Chat based Dialogs for Bot Builder:
// https://github.com/Microsoft/BotBuilder-PersonalityChat
// 
// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Linq;
using System.Net.Http;
using Microsoft.Bot.Builder.PersonalityChat.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.PersonalityChat.Core.Tests
{
    [TestClass]
    public sealed class PersonalityChatTests
    {
        [TestMethod]
        public async Task ExecutePersonalityChatTests()
        {
            string userQuery = "test query aswedff";
            string expectedResponse = "test response";
            PersonalityChatOptions personalityChatOptions = new PersonalityChatOptions();

            PersonalityChatService personalityChatService = new PersonalityChatService(personalityChatOptions, new HttpClient());

            PersonalityChatResults personalityChatResults = await personalityChatService.QueryServiceAsync(userQuery);

            string topResponse = personalityChatResults?.ScenarioList?.FirstOrDefault()?.Responses?.FirstOrDefault();

            Assert.AreEqual(expectedResponse, topResponse);
        }
    }
}