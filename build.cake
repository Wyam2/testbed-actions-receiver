var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

string gitTag = EnvironmentVariable("TAG") ?? Argument<string>("tag", string.Empty);;

Task("Package")
    .Does(() => { Information($"Ran Package target with git tag '{gitTag}'"); });

Task("Default")
    .IsDependentOn("Package")
    .Does(() => { Information("Ran Default target"); });

RunTarget(target);