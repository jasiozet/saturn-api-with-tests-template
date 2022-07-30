# F# Saturn API with tests template

## How to use it

Clone the repo!

## Requirements

[dotNET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Editor capable of working with F#, I personally recommend:
* [Visual Studio Code](https://code.visualstudio.com/) and [Ionide plugin](https://ionide.io/)

Other options:
* [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* [Rider](https://www.jetbrains.com/rider/)

## Stuff inside API

* [Saturn](https://saturnframework.org/)

Saturn is built on top of [Giraffe](https://giraffe.wiki/)
Take a look at these templates to compare the difference with other frameworks:
* [Giraffe](https://github.com/jasiozet/giraffe-api-with-tests-template)
* [Falco](https://github.com/jasiozet/falco-api-with-tests-template)

## Stuff inside TESTS
* [xUnit](https://xunit.net/)
* [FsUnit](https://fsprojects.github.io/FsUnit/)

## How to run:
* api - ```cd api && dotnet run```
* tests - ```cd tests && dotnet test```

## What if I don't want tests?

Just remove the ```tests``` folder!

## Why make this template?

Current Saturn template seems to be a little bit outdated and a lot of templates have full feature enabled from the start.
This is of course excellent when you know what you want and what you are doing, but a lot of people are coming to F# very fresh and they ask how to start building backends.
This template is meant a nice fresh start for them, without much complication

## TODO:
* Controller example

## Explore the basic api:
* http://localhost:5000/add/2/3 => 5
* http://localhost:5000/mul/2/3 => 6
* http://localhost:5000/json => {"language":"F#","message":"Hello World"}
* http://localhost:5000/anyRoute => htmled I |> F# Hello World