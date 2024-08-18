using Spectre.Console.Cli;

namespace Repro;

public class BranchSettings : CommandSettings
{
	[CommandOption("--my-value")]
	public string MyValue { get; set; } = string.Empty;
}
