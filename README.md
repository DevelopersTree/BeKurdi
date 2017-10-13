# Be Kurdi (بە کوردی)

Kurdish language is being written in three main alphabets: [Sorani Alphabet, Latin Alphabet And Crylic Alphabet](https://en.wikipedia.org/wiki/Kurdish_alphabets). This library provides a simple way to convert bodies of text between the different alphabets.

## How to use [![NuGet](https://img.shields.io/nuget/v/DevTree.BeKurdi.svg)](https://www.nuget.org/packages/DevTree.BeKurdi/)
First add the [nuget package](https://www.nuget.org/packages/DevTree.BeKurdi/) to your project:
```
PM> Install-Package DevTree.BeKurdi
```

Then add this using statement to the top of the class:
```csharp
using DevTree.BeKurdi;
```

Now you can normalize Sorani text like this:
```csharp
var text = "ضؤني";
var normalized = text.ToStandardSorani(); // will be converted to: چۆنی
```

## State of the project
This project is at its very early stages, but we do welcome contribution from everyone. You can help us in the following ways:
 - Progamming
 - Scientific guidance and testing
 - Writing/Maintaining Documentation
 - [Sending suggestions and reporting bugs](https://github.com/DevelopersTree/BeKurdi/issues)
 - Helping us to spread the word
 
### Build Status
 - master: [![Build Status](https://travis-ci.org/DevelopersTree/BeKurdi.svg?branch=master)](https://travis-ci.org/DevelopersTree/BeKurdi)
 - dev: [![Build Status](https://travis-ci.org/DevelopersTree/BeKurdi.svg?branch=dev)](https://travis-ci.org/DevelopersTree/BeKurdi)

## Resources
  - [ڕێنووسی زمانی کوردی](http://diyako.yageyziman.com/%DA%95%DB%8E%D9%86%D9%88%D9%88%D8%B3/)
  - [پڕۆژەی پەڵک کوردی‌نووس](http://chawg.org/kurdi-nus/)

## Licence
This project is being developed under [MIT License](LICENSE).
