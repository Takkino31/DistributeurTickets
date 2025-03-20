# DistributeurTickets


```md
# 🎟️ Distributeur de Tickets - C# Console App

Ce projet est une application console en **C#** qui simule un distributeur automatique de tickets pour une banque.  
Il gère trois types d'opérations : **Versement, Retrait et Informations**.  
Chaque client reçoit un ticket unique et le programme enregistre les tickets émis dans un fichier.

---

## 📌 Fonctionnalités  
✅ Saisie des informations du client (Nom, Prénom, Numéro de compte).  
✅ Attribution d’un ticket unique basé sur le type d’opération.
✅ Sauvegarde des numéros de tickets et des clients dans des fichiers.  
✅ Simulation de plusieurs clients.  
✅ Possibilité de quitter proprement le programme.
✅ Affichage de la liste des clients à la fin du programme.

---

## 📂 **Structure du Projet**
```
DistributeurTickets/
│── bin/                 # Fichiers compilés (Debug/Release)
│── obj/                 # Fichiers temporaires de compilation
│── Program.cs           # Code source principal
│── DistributeurTickets.csproj # Fichier de configuration du projet
│── /chemin-du-projet/DIstibuteurTickets/DIstibuteurTickets/bin/Debug/net9.0/fnumero.txt          # Stocke les derniers numéros attribués
│── /chemin-du-projet/DIstibuteurTickets/DIstibuteurTickets/bin/Debug/net9.0/clients.txt          # Liste des clients enregistrés
│── README.md            # Documentation du projet
```

### 📌 **📄 Emplacement des fichiers `fnumero.txt` et `clients.txt`**  
Les fichiers sont enregistrés dans :  
```
/chemin-du-projet/DIstibuteurTickets/DIstibuteurTickets/bin/Debug/net9.0
```
Assurez-vous de naviguer vers ce dossier pour les retrouver.

---

## 🛠 **Installation et Exécution**
### 🔹 **1. Cloner le projet**
```sh
git clone https://github.com/Takkino31/DistributeurTickets.git
cd DistributeurTickets
```

### 🔹 **2. Ouvrir avec JetBrains Rider**  
1. Lance **JetBrains Rider ou tout autre éditeur**.  
2. Ouvre le dossier **DistributeurTickets**.  
3. Vérifie que `.NET` est bien installé.  

### 🔹 **3. Exécuter l’application**
Depuis votre editeur, lance l'exécution avec **F5** ou via le terminal :  
```sh
dotnet run
```

---

## 🔄 **Fonctionnement du Programme**
1. Le programme affiche un menu demandant le type d'opération.  
2. Il demande les informations du client.  
3. Il génère un ticket et l’affiche à l’utilisateur.  
4. Il met à jour **fnumero.txt** et **clients.txt** pour conserver les numéros attribués et la liste des clients.  
5. À la fin, il affiche la liste des clients enregistrés.  
6. L’utilisateur peut **choisir de quitter** proprement le programme.

---

## 🤖 **Exemple d'Exécution**
```
=== 🏦 Bienvenue à la banque 🏦 ===
1. Versement
2. Retrait
3. Informations
4. Quitter
Votre choix : 1
Entrez votre numéro de compte : 123456
Entrez votre nom : TAKKINO
Entrez votre prénom : Yaya
Votre numéro est V-1. Il y a 0 personne(s) avant vous.

Voulez-vous prendre un autre numéro ? (O/N) : N

Liste des clients enregistrés :
TAKKINO Yaya - Compte: 123456 - Ticket: V-1

👋 Merci d'avoir utilisé notre service !
```

---

## 📜 **Licence**
Ce projet est sous licence MIT. Tu peux l'utiliser et le modifier librement.

---

## 💡 **Contact**
📧 Email : [takkinoyaya@gmail.com](mailto:takkinoyaya@gmail.com)  
📌 GitHub : [Takkino31](https://github.com/Takkino31)  
```
Mail : takkinoyaya@gmail.com
Github: https://github.com/Takkino31
Linkedin : https://www.linkedin.com/in/yaya-elimane-var-a15722174/

---


