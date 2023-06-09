﻿using Newtonsoft.Json.Linq;

namespace CSharpSeleniumFramework.Tests
{
    public class JsonReader
    {
        public JsonReader() { }

        public String extractData(String TokenName)
        {
            var myJsonString = File.ReadAllText("Tests/TestData.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(TokenName).Value<string>();
        }

        public String[] extractArrayData(String TokenName)
        {
            var myJsonString = File.ReadAllText("Tests/TestData.json");
            var jsonObject = JToken.Parse(myJsonString);
            List<String> arrayLists = jsonObject.SelectTokens(TokenName).Values<string>().ToList();
            return arrayLists.ToArray();
        }
    }
}
