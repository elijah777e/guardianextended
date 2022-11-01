﻿namespace Guardian.Features.Commands.Impl
{
    class CommandReloadConfig : Command
    {
        public CommandReloadConfig() : base("reloadconfig", new string[] { "rlcfg" }, string.Empty, false) { }

        public override void Execute(InRoomChat irc, string[] args)
        {
            irc.AddLine("Reloading configuration files...");
            GuardianClient.Properties.LoadFromFile();
            irc.AddLine("Configuration reloaded.");

            irc.AddLine("Reloading skin host allowlist...");
            AntiAbuse.Validators.SkinValidator.Init();
            irc.AddLine("Skin host allowlist reloaded.");
        }
    }
}