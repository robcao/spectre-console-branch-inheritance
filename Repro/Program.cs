using Repro;
using Spectre.Console.Cli;

CommandApp app = new();

app.Configure(config =>
{
	config.ValidateExamples();
	config.AddBranch<BranchSettings>("branch", user =>
	{
		user.SetDescription("Branch.");

		user.AddCommand<BranchedCommand>("command")
			.WithDescription("Command under a branch.")
			.WithExample("branch", "command", "--my-value", "abc");
	});
});

return app.Run(args);
