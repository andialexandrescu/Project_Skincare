# Skincare_Project_ASP.NET
## Working with branches

### Begin your work session by pulling in changes from GitHub 
```
git pull origin main // pulling changes from the main branch
OR
git pull origin new-feature // // pulling changes from the new-feature branch
```
### Optional: Creating a new feature branch off of main (secondary branch)
```
git checkout main
git checkout -b new-feature // any branch name
```
### Optional: Downloading someone else's work from a secondary branch; fetch will "download" commits from GitHub, without merging them
```
git fetch origin
git checkout adas-feature
```
### If necessary, resolve any merge conflicts and commit them
```
git add .
git commit -m "Merge in changes from GitHub"
```
### Do your work, then add, commit and push
```
git add .
git commit -m "Make progress on project" // git commit -m "Add progress on feature"
git push origin branch-name // modifying the current branch
```
## Project description
Platforma “Online shop” cu urmatoarele functionalitati:
 - [ ] Sa existe 4 tipuri de utilizatori: utilizator neinregistrat, inregistrat, colaborator, administrator (0.5p).
 - [ ] Utilizatorul colaborator poate adauga produse in magazine. Acesta va trimite cereri de adaugare administratorului, iar acesta le poate respinge sau aproba.
       Dupa aprobare produsele vor putea fi vizualizate in magazin (1.0p).
 - [ ] Produsele fac parte din categorii. Categoriile sunt create dinamic de catre administrator. Dinamic insemnand ca acesta poate adauga noi categorii direct din
       interfata aplicatiei. De asemenea, adminul este cel care poate vizualiza, edita si sterge categoriile ori de cate ori este necesar (1.0p).
 - [ ] Un produs are titlu, descriere, poza, pret, stoc, rating (1-5 stele), review-uri din partea utilizatorilor. Fiecare utilizator acorda un rating de la 1 la 5.
       Ratingul nu este un camp obligatoriu. In final, fiecare produs are un scor, calculat pe baza tuturor ratingurilor existente. Review-ul este un comentariu de tip
       text lasat de utilizatori. Acest camp nu este obligatoriu. Restul campurilor sunt obligatorii. Stocul reprezinta numarul de produse din baza de date. (1.0p).
 - [ ] Utilizatorul colaborator poate sa editeze si sa stearga produsele adaugate de el. Dupa editare, produsul necesita din nou aprobare din partea administratorului (1.0p).
 - [ ] Utilizatorul neinregistrat va fi redirectionat sa isi faca un cont atunci cand incearca adaugarea unui produs in cos. Atunci cand nu are cont, el poate doar sa vizualizeze
       produsele si comentariile asociate acestora (0.5p).
 - [ ] Atunci cand un utilizator devine utilizator inregistrat poate sa plaseze comenzi (sa adauge produse in cos) si sa lase review-uri (nota sau text), pe care ulterior le poate
       edita sau sterge (1.0p).
 - [ ] Atunci cand un utilizator adauga un produs in cos, acesta poate selecta si cantitatea. In momentul in care se plaseaza (fictiv) comanda, stocul produsului trebuie sa scada
       corespunzator, in functie de numarul de produse achizitionate (0.5p).
 - [ ] Produsele pot fi cautate dupa denumire prin intermediul unui motor de cautare. De asemenea, produsele nu trebuie cautate dupa tot numele. Ele trebuie sa fie gasite si in cazul
       in care un utilizator cauta doar anumite parti care compun denumirea (1.0p).
 - [ ] Rezultatele motorului de cautare pot fi sortate crescator, respectiv descrescator, in functie de pret si numarul de stele (se vor implementa filtre din care un utilizator poate
       sa aleaga) (0.5p).
 - [ ] Administratorul poate sterge si edita atat produse, cat si comentarii. Acesta poate, de asemenea, sa activeze sau sa revoce drepturile utilizatorilor (1.0p).
       
## Schema
- products: id, title, description, price, image, availability, rating, vector(properties)
- cart_products: id_cart, is_produs, cantitățe (constraint: >= 1)
- cart: id_cart
- review: scor, comentariu, user_asociat (fk: id_user)
- user: id, nume, parola, mail, telefon etc
- category: id_categorie, nume_categorie, description
