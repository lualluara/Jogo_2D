# Jogo_2D
Jogo de treinamento de versionamento de código

*25/08* - Hoje aprendemos sobre pull, push, branch e merge. Em um projeto da unity, fizemos um player a main branch, e após isso, fizemos um chão na branch de testes. Depois fizemos um merge de ambas branch's. Observamos como as coisas funcionam dentro da GitHub Desktop(códigos, pastas, comandos e etc.)

*17/09* - Na aula do dia 17 de setembro, continuamos o nosso projeto para o Mundo Senai. Fizemos uma pasta e criamos um script sobre o player, adicionando o RigidBody2D, desse modo adicionando física ao player, também adicionamos um código para reconhecer o movimento horizontal, concedendo movimentação ao player. Após isso, adicionamos a colisão para o chão e o player. Adicionamos pulo ao player.

*22/09* - Nesta aula criamos a variável que faz o player pular somente uma vez, voltando ao chão. Criamos a variável dos isGrounded, e criamos o void OnCollisionEnter2D (verifica se o pulo é verdadeiro e faz o player pular)  e OnCollisionExit2D (Faz o player pular somente uma vez). Criamos a Tag "Ground" e adicionamos ao chão, também fizemos a mudança de adicionar a câmera ao player, desse modo, quando o player anda agora a câmera o segue.

*24/09* - Na aula de hoje é para criarmos um mapa, fiz o total de 3 cenários, um onde o personagem irá começar o jogo( o quarto dele),a sala de aula(onde ele vai achar as fases), e a fase.
Quarto: adicionei os móveis(cama, guarda-roupas, mesa de estudos);
Sala de aula: adicionei a porta, mesas dos alunos, mesa do professor;

*29/09* - Na aula de hoje, fiz algumas mudanças no cenário. Adicionei prateleiras no quarto, papel de parede no quarto. ocorreu mudanças na fase adicionamos espinhos para ser o dano e fizemos uma PreFab dele.
PreFab: Uma pasta onde adiconamos um espinho, dessa forma, os códigos e configurações estarão pré-fabricados, facilitando a montar o cenário.

*06/10* - Hoje a projeto foi aprimorado, ocorreram mudanças na fase, de forma que os obstáculos e as plataformas mudaram de posição. As mudanças ocorreram por que o jogo não estava dinâmico o suficiente. Também foi implementado o ataque e o inimigo.

*08/10- Pesquisa SceneManager*: O SceneManager é uma ferramenta fundamental da Unity para o gerenciamento de cenas durante a execução de um jogo. Em jogos 2D, ele pode ser utilizado para organizar diferentes partes do projeto, como o menu principal, fases, telas de Game Over, configurações e créditos. Cada cena pode conter diferentes objetos, personagens, cenários, câmeras, elementos de interface e outros componentes necessários para determinada parte do jogo. Em um jogo 2D, o SceneManager pode ser utilizado para criar uma estrutura organizada de progressão.

Um projeto pode possuir uma cena para o menu principal, outras para cada fase e uma cena específica para o Game Over. Quando o jogador termina uma fase, o jogo pode utilizar o SceneManager para carregar a próxima. Da mesma maneira, caso o jogador perca, o sistema pode carregar a tela de Game Over.

Portanto, o SceneManager é uma ferramenta essencial para organizar e controlar o fluxo de um jogo desenvolvido na Unity. Seus recursos permitem realizar desde simples trocas de fases até sistemas mais complexos de carregamento assíncrono e gerenciamento de múltiplas cenas. Em projetos 2D, seu uso facilita a organização do jogo e permite separar diferentes partes do projeto de maneira mais eficiente, contribuindo para uma estrutura mais organizada e fácil de manter.

*o que foi feito em aula*: Na aula de hoje, melhorei o chão e implementei uma mecânica do SceneManager.
