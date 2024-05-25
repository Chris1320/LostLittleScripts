$RclonePath = "D:\rclone\rclone.exe"
$ConfigFile = "C:\Users\<USERNAME>\AppData\Roaming\rclone\rclone.conf"
$LogFile = "D:\rclone\log.txt"

$StartCommand = @("mount")
$AdditionalMountOptions = @(
    "--config", "`"$ConfigFile`"",
    "--log-file", "`"$LogFile`"",
    "--log-level", "INFO",

    # VFS switches
    "--vfs-cache-mode", "full",
    "--vfs-read-chunk-size", "32M",
    "--vfs-read-chunk-size-limit", "off",

    # Remote switches
    "--dir-cache-time", "5m0s",

    # Google Drive switches
    "--drive-chunk-size", "64M",

    "--network-mode",
    "--no-console"
)

function Start-Rclone-Mount {
    param (
        [Parameter(Mandatory=$true)] [string]$RemoteName,
        [Parameter(Mandatory=$true)] [string]$DriveLetter,
        [Parameter(Mandatory=$true)] [string]$VolumeName
    )

    # Build the command's argument list.
    $MountOptions = @("${RemoteName}:", "${DriveLetter}:", "--volname", "`"$VolumeName`"")
    $CmdArgs = $StartCommand + $MountOptions + $AdditionalMountOptions

    Write-Output "[+] Mounting ${VolumeName} to ${DriveLetter}: (remote: ${RemoteName})..."
    Start-Process -FilePath "$RclonePath" -NoNewWindow -ArgumentList $CmdArgs
}

Write-Output "Starting rclone processes..."

# WARN: Change the values here!!!
Start-Rclone-Mount -RemoteName "gdrive-personal" -DriveLetter "Q" -VolumeName "Personal (GDrive)"
Start-Rclone-Mount -RemoteName "onedrive-personal" -DriveLetter "R" -VolumeName "Personal (OneDrive)"
Start-Rclone-Mount -RemoteName "mega-personal" -DriveLetter "S" -VolumeName "Personal (MEGA)"

Start-Rclone-Mount -RemoteName "gdrive-education" -DriveLetter "T" -VolumeName "Education (GDrive)"

Start-Rclone-Mount -RemoteName "gdrive-work" -DriveLetter "U" -VolumeName "Work (GDrive)"
Start-Rclone-Mount -RemoteName "onedrive-work" -DriveLetter "V" -VolumeName "Work (OneDrive)"

Write-Output "Starting rclone processes... Done!"
