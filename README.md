# Diploma-Useful
useful stuff from my diploma

<hr>
Tukaj so naloženi bolj ali manj uporabni deli iz moje diplomske naloge <b>Navidezno resnični sistem za interakcijo z molekulskimi strukturami na osnovi Oculus Rift očal in globinskih senzorjev</b>
<hr>
leap.avi je filmček, ki prikazuje uporabo senzorja Leap Motion za interakcijo z molekulo vode.
<hr>
connect.cs je ena prvih skript, ki sem jih napisal za potrebe diplomske naloge.

V glavnem potreboval sem nekaj kar bo predstavljalo vezi med molekulami, zato sem najprej poskušal najti nekaj uporabnega na internetu, vendar nisem našel nič ustreznega, sem pa dobil idejo na enem izmed Unity3D forumov.

Torej kako deluje skripta connect.cs.

Želimo torej narediti povezavo med dvema objektoma, ta objekta sedita v 3D prostoru, ki je določen z globalnim koordinatnim sistemom. Objekta sta določena z dvema točkama oz. z dvema vektorjema, imata tudi svoj lokalni koordinatni sistem. Vektor kaže na središče oz. težišče objekta.

-Torej imamo 2 vektorja start, end in neko širino width, ki jo uporabimo za določanje širine objekta ki bo služil za vez, v našem primeru je to valj.

Najprej izračunamo razliko vektorjev end in start, s tem dobimo vektor offset. S pomočjo tega vektorja določimo velikost valja "scale", ter njegovo pozicijo.

Nato kreiramo valj, mu izklopimo "collider", ter mu določimo pozicijo, velikost in usmerjenost. Pravino usmerjeost dosežemo z rotacijo lokalnega koordinatnega sistema valja glede na globalni koordinatni sistem. To je mogoče ker je koordinatni sistem definiran z vektorji up, right, forvard (y, x, z), torej če izenačimo vektor up z vektorjem offset, rotiramo cel koordinatni sistem.

