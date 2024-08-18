using Spectre.Console.Cli;

namespace Repro;

public class BranchedCommand : Command<BranchedCommandSettings>
{
	public override int Execute(CommandContext context, BranchedCommandSettings settings) => 0;
}
