using Dalamud.Plugin;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks
{
    internal sealed class ClickVoteMvp : ClickBase
    {
        protected override string Name => "VoteMvp";
        protected override string AddonName => "VoteMvp";

        public unsafe ClickVoteMvp(DalamudPluginInterface pluginInterface) : base(pluginInterface)
        {
            AvailableClicks["votemvp_button"] = (addon) => SendClick(addon, EventType.CHANGE, 1, ((AddonVoteMvp*)addon)->VoteButton->AtkComponentBase.OwnerNode);
            AvailableClicks["player1_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check1->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player2_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check2->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player3_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check3->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player4_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check4->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player5_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check5->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player6_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check6->AtkComponentButton.AtkComponentBase.OwnerNode);
            AvailableClicks["player7_checkbox"] = (addon) => SendClick(addon, EventType.CHANGE, 3, ((AddonVoteMvp*)addon)->check7->AtkComponentButton.AtkComponentBase.OwnerNode);
        }
    }
}
