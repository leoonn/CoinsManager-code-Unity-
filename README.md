# CoinsManager-code-Unity-
Código para manipulação de moedas do jogador 

Codigo para manipulçao de moedas do jogador 

Adicione este script em um gameobject de sua cena de menu e referencie o text e inicie a variavel int a 0 no inspector.
No meu jogo que o utilizei toda vez que a cena de menu era carregada, ele utilizava o getcoins() um metodo para chamar 
o playerprefs um component de script da unity usado para salvar valores em variaveis, sem perda de dados, a nao ser que
o usuario desinstale o jogo, com isso o menu sempre buscava a quatindade de moedas que jogador obtinha em faases com a 
ajuda do setcoins() um metodo que utiliza o playerprefs tambem porem esse salva os dados na variavel enquanto o get 
chama esse valor salvo para a variavel.

Um exemplo para melhor entendimento.

se chamarmos o setcoins ao iniciar o jogo apertando em um botao de play, ele salvará a quantidade de moedas do jogador na cena de menu, 
mandando esse valor para uma chave em que em outra cena pode ser buscado utilizando o getcoins, uma variavel local e a chave em que foi salva. 
Assim voce conseguirá em outra cena atribuir um valor a variavel em que o get buscou. Contudo ao sair dessa cena apertando um botao que irá 
para o menu do jogo por exemplo, deve-se chamar o metodo setcoins novamente para salvar o valor na variavel da cena de menu utilizando a chave e 
chamar o getcoins no menu puxando para a variavel local da cena menu atribuindo a UI.

Esta é uma forma muito interessante para salvar dados e transferi-los para outras cenas sem perde-los.

# CoinsManager-code-Unit-
Code for player coin handlers

Code for player coin manipulation

Place this script in a gameobject of your menu and reference or text scene and set the int variable to 0 in the inspector.
In my game I used it every time the menu scene was loaded, it used getcoins() a method to call
playerprefs is a unit script component used to save values to variables, without data loss, unless
the user uninstalls the game, with that the menu always looked for the amount of coins that the player got in phases with the help
setcoins() a method that uses playerprefs too but this saves the data in the variable while get
calls this saved value for a variable.

An example for better understanding.

if we call setcoins when starting the game by pressing a play button, it will save the amount of player coins in the menu scene,
sending this value to a key that in another scene can be fetched using getcoins, a local variable and a key in which it was saved.
So you'll get it in another scene assign a value to the variable in which you get searched. However when you leave this scene by pressing a button that will
for the game menu for example, you must call the setcoins method again to save the value in the menu scene variable using a key and
call getcoins in the menu by pulling a local variable from the scene's menu by assigning a UI.

This is a very interesting way to save data and transfer it to other scenes without losing it.
