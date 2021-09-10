using System.Collections.Generic;

namespace Sharpway.JavaScript {
    public static class GeneralContent {
        public static Dictionary<string, string> GeneralTags = new Dictionary<string, string>() {
            /* Syntax Indicators */
            {"{", "(`"},
            {"<{", "`+"},
            {"}>", "+`"},
            {"}", "`)"},
            {":", "{"},
            {"=>", ":"},
            /* Page Basics Definition */
            {"PageDefine", @"sharpway.pageDefine"},
            {"Page<Title>", "sharpway.handlePageTitle"},
            {"Page<Version>", "sharpway.handlePageVersion"},
            {"Page<Icon>", @"sharpway.handlePageIcon"},
            {"Append", "sharpway.domAppend"},
            {"Render<html>", "document.body.innerHTML += "},
            /* Semantics Indicators */
            {"end", "}"},
            {"def", "function"},
            /* Misc */
            {"println<Error>", "console.error"},
            {"printLn<Warn>", "console.warn"},
            {"printLn<Text>", "console.log"},
            {"println", "console.log"}
        };
    }
}