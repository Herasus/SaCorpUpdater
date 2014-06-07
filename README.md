SaCorpUpdater-CSharp
====================

Updater pour logiciel codé en C#

--------------------
Features
--------------------

- Mise à jour via un serveur en ligne (http ou ftp)
- Mise à jour dans des dossiers *.zip (*.rar en version VB6)
- Background modifiable
- Utilisation simple
- Téléchargement avec informations (progressbar)

--------------------
Comment l'utiliser
--------------------

Comment utiliser SaCorpUpdater V2 :
- Uploader le dossier serveur sur votre FTP
- Placer les fichiers SaCorpUpdater.exe, SharpZipLib.dll et Config\Launcher.ini à la racine de votre programme
- Ouvrir le fichier Config\Launcher.ini et modifiez-le.

-----

Comment ajouter une version :
Allez dans le dossier Serveur de votre FTP.
Ouvrez le fichier update.ini :
[FILES]
versions=Le nombre de versions de votre programme

et dans le même dossier, créer une archive avec le nom "versionX.zip" (où X correspondant au numéro de version) avec les fichiers MAJ dedans.

-----

Pour modifier le background :
Modifiez le fichier Config\sacorpupdater.jpg par l'image de votre choix.

