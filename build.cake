#load nuget:?package=Cake.Dungeon&prerelease

Build.SetParameters
(
    title: "cake-docker",

    defaultLog: true,

    runDockerBuild: true,
    runPublishToDocker: true,

    dockerPushLatest: true,

    dockerImages: new[] { new DockerImage { Repository = "dockfool/cake-docker" } }
);

Build.Run();
