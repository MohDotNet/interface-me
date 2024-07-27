About this project.

The objective was to mask sensitive data bafore that data is being written to a log file or database.

The challenge i had was that no two responses are the same, and no two request bodies are the same.
this solution saw me leveraging off Interfaces in the C# language to achieve a sheer generate masking implimentaiton.

The developer cna pass through any request of any object, as long as such object inherits from IResponse.
To decide which fields should be masked, further inheritance of interfaces is required in object.

THey are:
* IResponse
* IActivation
* IPin
* IDigiPin

Technically you can add as many as you require/
