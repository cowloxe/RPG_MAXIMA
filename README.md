RPG_MAXIMA
YOU ARE A POLICE OFFICER AND YOUR LOCAL MAXIMA IS UNDER ATTACK
SPĒLES APRAKSTS

Tu esi policists, kurš tika izsaukts uz Maximau, jo izcēlās kautiņš. Tavs mērķis ir atrisināt situāciju uzveicot visus pretiniekus.
Fona attēlu paņēmu no Google, mūziku no Freesound un pogu sprites un pretinieku sprites izveidoju pati Krita programmā. 

PAPILDUZDEVUMI

3 DAŽĀDI PRETINIEKI

Spēlē ir trīs dažādi pretinieki, katram ir savs unikāls uzbrukuma veids:

Gopnik: vienkāršs pretinieks kurš sit ar dūrēm. Dara parastu damage.
Granny: vecenīte kas sit ar spieķi, bet viņai ir arī iespēja izvairīties no taviem uzbrukumiem (dodge). Tāpēc viņa var būt grūtāk uzveicama.
Drunk Guard: piedzēries apsargs kurš met ar pudeli un saindē tevi (poison efekts). Indēšana dara papildus damage.

PRETINIEKU RANDOM SPAWN

Kad pašreizējais pretinieks tiek uzvarēts, nākamais pretinieks tiek izvēlēts nejauši.

VIZUĀLIE ELEMENTI

Izveidoju pati Krita programmā sprites priekš visiem trim pretiniekiem un pogām. Fona attēls paņemts no Google. Spēlei ir arī fona mūzika kas tiek atskaņota spēles laikā.

HP NEIET ZEM 0

Pievienoju pārbaudi ka HP nevar nokrist zem 0. Ja damage ir lielāks nekā atlikušais HP, tas vienkārši paliek uz 0.

OOP PRINCIPI

1. Mantošana
Projektā ir galvenā klase Character, kas satur kopīgo funkcionalitāti piemēram health, vārdu un TakeDamage metodi. No šīs klases tiek mantoti Player un Enemy. Līdzīgi arī Weapon ir parent no kuras izriet konkrēti ieroču tipi, kas katrs papildina GetDamage() ar savu uzbrukuma mehāniku.

2. Enkapsulācija
Daži mainīgie ir paslēpti ar private, lai tos nevarētu brīvi mainīt no citām klasēm. Piemēram charName var tikai izlasīt caur getter, bet no ārienes to nevar pārrakstīt. Tāpat canHeal ir aizsargāts ar getter: citas klases redz, bet pašu vērtību tiešā veidā nomainīt nevar.

3. Polimorfisms
Override: Player un Enemy katrs realizē savu Attack() metodes versiju, jo uzbrukuma loģika atšķiras. Piemēram Gopnik vienkārši sit, Granny var izvairīties, bet Drunk Guard indē. Tāpat ieroču klases pārraksta GetDamage() lai katram ierocim savs damage būtu aprēķins. Overload: TakeDamage() eksistē divās versijās: viena saņem skaitlisku damage vērtību, otra saņem Weapon objektu no kura pati izvelk damage.
4. Abstrakcija
Character ir abstrakta klase, kas nozīmē ka no tās tiešā veidā objektu izveidot nedrīkst. Tā definē abstraktu Attack() metodi, kuru obligāti jāimplementē katrā child klasē. Weapon savukārt izmanto virtuālu GetDamage() metodi, ko child klases var pielāgot savām vajadzībām.
