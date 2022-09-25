
https://github.com/zackradisic/aussieplusplus/

https://aussieplusplus.vercel.app/


functions:

```
7:THE HArD YAkkA FOr drunk_speak IS () <
12:THE HArD YAkkA FOr sober_up IS (ya_beer) <
38:THE HArD YAkkA FOr a_pint IS () <
44:THE HArD YAkkA FOr drink_at_the_bar IS () <
54:THE HArD YAkkA FOr i_dont_feel_so_good IS (upset_tummy, beer)  <
74:THE HArD YAkkA FOr hiccup IS () <
```

is each function called?

for i in drunk_speak sober_up a_pint drink_at_the_bar i_dont_feel_so_good hiccup; do echo --- $i --- ;rg $i notupsidedown.aussie;done


all variables:

```
rg -o 'I rECkON (.*) =' notupsidedown.aussie|cut -d ' ' -f 3
```

unused vars:

```
while read v; do echo ---- $v ---- ;rg $v notupsidedown.aussie | rg -v 'I rECkON'; done < vars
---- aussie ----
---- the_pin ----
---- you_drongo ----
---- what_i_won_on_the_races ----
		what_i_won_on_the_races = -10;
		what_i_won_on_the_races = 250;
	bAIL tell_her % what_i_won_on_the_races;
---- ya_should ----
---- tell_her ----
	bAIL tell_her % what_i_won_on_the_races;
---- i_need_a_ride_home ----
a_hiccup = a_hiccup + i_need_a_ride_home;
---- a_number ----
---- we_oughta ----
---- a_flag ----
	bAIL a_flag;
---- my_flag ----
---- pint ----
	GIMME "Ish.. just one.. more *hic* pint..";
THE HArD YAkkA FOr a_pint IS () <
---- pin_for_flag ----
---- we_can_find_a_beer_here_somewhere ----
YA rECkON we_can_find_a_beer_here_somewhere == bUGGEr ALL ? <
---- me_sons_birthday ----
---- the_flag ----
GIMME i_should_print_the_flag;
---- what_the_missus_wants ----
// GIMME what_the_missus_wants;
GIMME what_the_missus_wants;
---- i_had ----
---- too_much_to_drink ----
---- a_hiccup ----
a_hiccup = a_hiccup + i_need_a_ride_home;
---- i_should_print_the_flag ----
GIMME i_should_print_the_flag;
```

unused:
```
---- aussie ----
---- the_pin ----
---- you_drongo ----
---- ya_should ----
---- a_number ----
---- we_oughta ----
---- my_flag ----
---- pin_for_flag ----
---- me_sons_birthday ----
---- the_flag ----
---- i_had ----
---- too_much_to_drink ----

```


```
for i in $(cat unusedvars); do echo GIMME \"$i\" +  $i\; ; done
GIMME "aussie" + aussie;
GIMME "the_pin" + the_pin;
GIMME "you_drongo" + you_drongo;
GIMME "ya_should" + ya_should;
GIMME "a_number" + a_number;
GIMME "we_oughta" + we_oughta;
GIMME "my_flag" + my_flag;
GIMME "pin_for_flag" + pin_for_flag;
GIMME "me_sons_birthday" + me_sons_birthday;
GIMME "the_flag" + the_flag;
GIMME "i_had" + i_had;
GIMME "too_much_to_drink" + too_much_to_drink;
```

https://h4sh5.github.io/CyberChef/#recipe=From_Base32('A-Z2-7%3D',true)&input=SVJLVUdWQ0dQUERKQlJVV0tOSlc1WVVJUUJQNFRPSzdOWlBYSFJVV1pHUzRWQjI3SVRSSVJBR0dT

base32

```
DUCTF{ƐƖSSn∀_ɹ_n_sƖɥʇ_D∀Ƙ
```

DUCTF{KAD_th1s_u_r_AuSS13}

DUCTF{KAD_this_u_r_AuSSI3}
