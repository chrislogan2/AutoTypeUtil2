# AutoTypeUtil2
I find myself frequently creating little ad-hoc entries in Keepass that serve as a vessel to autotype into various remote consoles that don't support or allow clipboard passthrough.
This utility should solve that. As long as I am using Bitwarden as my source of secrets I can forsee a need for this.  

<img width="306" height="193" alt="image" src="https://github.com/user-attachments/assets/f7b54a47-6b76-47e6-8fb3-c4e09f72a757" />

Building:
1. Update SignThumbprint to your code signing cert, or completely disable signing by setting SignProject to False.
2. Build the solution, enjoy.
I intend to distribute via MS Store/winget in the future, will link there at some point.

Features:
* Programmable Delay in milliseconds.
* Ability to paste from clipboard.
* Hide text box for sensitive entries.
* Ability to register global hotkey to be "summoned" from background while running. (CTRL+ALT+SPACE by default, but can be set in the preferences file)
* Save/Load preferences.

Please create an issue/PR/FR if you come across any bugs, have any ideas for features, etc.
Limitation(s):
* text length in text box is only 32767 chars presently, if you're pasting from the clipboard this limitation won't apply.
* no dark mode :(
* No hotkey registration to initiate auto type ?
