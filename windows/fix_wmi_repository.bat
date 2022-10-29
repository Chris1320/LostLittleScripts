rem Based on the following Reddit post:
rem https://www.reddit.com/r/PowerShell/comments/tcoxcx/repairing_wmi_in_2022/i0i1fwd/

@echo off

echo [i] Disabling and stopping WMI service...
sc config winmgmt start=disabled
net stop winmgmt /y

echo [i] Salvaging and resetting repository...
winmgmt /salvagerepository
winmgmt /resetrepository

echo [i] Enabling and restarting WMI service...
sc config winmgmt start=auto
net start winmgmt
