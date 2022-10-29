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
