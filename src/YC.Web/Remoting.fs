namespace YC.Web

open WebSharper

module Remoting =

    [<Remote>]
    let Process input =
        async {
            return "You said: " + input
        }
