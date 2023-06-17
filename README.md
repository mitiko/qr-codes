# QR code scanner app

Scan multiple QR codes and save the decoded text to a file.  
Made with a simple .NET server + [qr reader library](https://github.com/mebjas/html5-qrcode) in under 100LoC.

Uses an in-memory hashset as database, intended for single user fast scanning.
I managed to scan 68 qr codes from receipts in under 2 mins.

## Use

Run the server: `dotnet run`  
Find your ip: `ifconfig | grep -oP "inet 192\.168\.\d+\.\d+"`  
Open the website at `https://<your server ip>:5001`  
Scan all the codes, then click `Write`  
Your output will be saved to a file named `qr-codes.txt` (delimited by new lines)
