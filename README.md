# SpeechRecognitionFromFiles
A .NET Core console app that transcribes .WAV audio files to text using Azure Speech service.

To use:
1. Create a Speech resource in Azure (https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/get-started#create-a-speech-resource-in-azure)
2. Update SpeechRecognitionFromFile.cs to have your Azure subscription key and service region.
3. Run `dotnet build`.
4. Run `dotnet run -- C:\\temp\\input\\` (using your own path to a directory that contains .WAV files)
5. When it finishes running successfully the transribed text will be in `output.txt`.

I used these resources to build this:
* http://www.luisquintanilla.me/2018/02/11/transcribing-podcasts-microsoft-speech-api/
* https://github.com/Azure-Samples/cognitive-services-speech-sdk/tree/master/samples/csharp/sharedcontent/console
