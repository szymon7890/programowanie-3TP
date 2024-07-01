#Utwórz listę hitsTitles zawierającą tytuły: 'BROTHERS IN ARMS','BOHEMIAN RHAPSODY','STAIRWAY TO HEAVEN','RIDERS ON THE STORM','WISH YOU WERE HERE'
hitsTitles = ['BROTHERS IN ARMS', 'BOHEMIAN RHAPSODY', 'STAIRWAY TO HEAVEN', 'RIDERS ON THE STORM', 'WISH YOU WERE HERE']
#Dodaj do listy kolejne dwie piosenki: 'CHILD IN TIME' i 'AGAIN'
hitsTitles.append('CHILD IN TIME')
hitsTitles.append('AGAIN')
#Wygląda na to, że w systemie głosowania była luka. Na pozycji 3 powinna się znaleźć piosenka 'HOTEL CALIFORNIA'
hitsTitles.insert(3,'HOTEL CALIFORNIA')
#Ops... wygląda na to, że system był bardziej zepsuty... oczywiście to wina IT. Piosenka 'THE SOUND OF SILENCE' powinna znaleźć się na pierwszym miejscu
hitsTitles.insert(1,'THE SOUND OF SILENCE')
#To na jakiej pozycji jest teraz 'HOTEL CALIFORNIA'? Odnajdź numer indeksu dla tej piosenki
print(hitsTitles.index('HOTEL CALIFORNIA'))
#A jednak 'HOTEL CALIFORNIA' powinien zostać usunięty z listy
hitsTitles.remove('HOTEL CALIFORNIA')
#No i na pierwszym miejscu tytuł "THE SOUND OF SILENCE" powinien zostać zamieniony na "ENJOY THE SILENCE"
hitsTitles.insert(1,'ENJOY THE SILENCE')
#Utwórz kopię listy, która będzie służyła do odczytania przebojów na antenie. Nowa lista ma nazywać się hitsToRead
hitsToRead = ['empty']
hitsTitles.extend(hitsToRead)
hitsTitlesCopy = hitsTitles.copy()
hitsTitlesCopy.clear()

print(hitsTitlesCopy)
#Lista do odczytania ma zawierać elementy w odwrotnej kolejności. Odwróć kolejność elementów na liście hitsToRead. 
print(hitsTitles)
#Lista do odczytania ma zawierać elementy w odwrotnej kolejności. Odwróć kolejność elementów na liście hitsToRead.
print(hitsToRead)
print(sorted(hitsToRead))
#A jednak dzisiaj lista przebojów będzie  wyjątkowo prezentowana w kolejności alfabetycznej. Posortuj hitsToRead w kolejności alfabetycznej
hitsToRead.sort()
print(hitsToRead)
#Prowadzący listę przebojów po odczytaniu tytułu usuwa z listy hitsToRead usuwa odczytany element. Dlatego korzysta z metody pop :). Zasymuluj odczyt dwóch pierwszych pozycji
print(hitsToRead.pop(0))
#W czasie audycji słuchacze domagali się aby zagrać dodatkowo 'NOTHING COMPARES 2 U' i 'WISH YOU WERE HERE'. Utwórz listę additionalSongs zawierającą te dwa tytuły.
additionalSongs = ['NOTHING COMPARES 2 U', 'WISH YOU WERE HERE']
print(additionalSongs)
#Dodaj do listy hitsToRead elementy z listy additionalSongs
additionalSongs.append()
