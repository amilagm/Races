# ReadMe

## How to run the solution

- Make sure you have .net core 2.1 installed
- Open the solution in Visual Studio
- Restore nuget packages if necessary
- Press F5 ro start

## Important Info

Since this had a 2hr time limit I prioritized getting the important unit tests and a working solution over more production ready exception handling / logging

## Things I would have done if I had more time

- Parameter validations for public methods
- Better exception handling
  - Catch exceptions at layer boundaries, log them and then throw more general exceptions to the calling layer
- Make the file feeds be read from text files rather than the embedded-resource file
  - I used the feeds as embedded resources for the unit tests as they work better when running iunit test in a CI/CD pippe line. But in a real production system, the actual feeds will be read from a file location rather than from an embedded resource
- Move the feed confugiration into a config file
  - So that enabling / disabling of a feed can be done via a config and feed specific settings will be managed via the config file as well.
- Logging
- Incresed test coverage
- Use async methods for file access and then use parallel processing on feeds rather than processing the feeds sequentially
- Refactor the generated classes for the feeds

## Assumptions

- Feeds are small enough to process in-memory - so that they can be de-serialized into their object representaion
- Structure of the feeds won't change too often