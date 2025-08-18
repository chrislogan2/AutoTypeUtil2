# AutoTypeUtil2
I find myself frequently creating little ad-hoc entries in Keepass that serve as a vessel to autotype into various remote consoles that don't support or allow clipboard passthrough.
This utility should solve that. As long as I am using Bitwarden as my source of secrets I can forsee a need for this.

Features:
* Programmable Delay in milliseconds.
* Ability to paste from clipboard.
* Hide text box for sensitive entries.
* Ability to register global hotkey to be "summoned" from background while running. (CTRL+ALT+SPACE by default, but can be set in the preferences file)
* Save/Load preferences.

Please create an issue/PR/FR if you come across any bugs, have any ideas for features, etc.
Limitation(s):
* text length in text box is only 32767 chars presently, unsure of max in actual clipboard however.
* no dark mode :(
