Football TimeTracker

-- Objectivo --
Simples Software de contagem de tempo de jogo em jogos de futebol.
O Objectivo é proporcionar dados que motivem a discussão do tempo útil de jogo em jogos de futebol.
Ferramenta criada para uma pessoa conseguir facilmente cronometrar o tempo "perdido" num jogo através de mudanças rápidas do estados de jogo via clicks de rato ou pressionando teclas enquanto vê o jogo.
Sendo uma ferramenta, a sua utilidade será proporcional à forma de como é usada.

-- Utilização --
Correr o programa e Utilizar teclas (ou rato) para alterar a diferente cronometrização. O software detecta as teclas pressionada mesmo não tendo a aplicação em foco.
Utilizar botão Iniciar/Terminar para começar e terminar cada parte. É sempre assim que se inicia a contagem.
Utilizar teclas definidas para alternar entre os diferentes tipos de estados de jogo.
Em caso de engano, utilizar o botão "desfazer ultimo segmento" para apagar o segmento corrente e voltar ao anterior.

-- Estados de jogo --
Existem 4 estados de jogo possíveis:
  - "A seguir" - cor verde - para quando a bola está em jogo e os jogadores estão de facto a jogar. Definido por defeito na tecla "W"
  - "Bola fora do terreno de jogo" - cor amarela - para quando a bola ultrapassa os limites do campo e terá de ser reposta. Definido por defeito na tecla "A"
  - "Arbitro interrompeu jogo" - cor vermelha - para quando o arbitro interrompe o jogo por que razao seja (ex: falta/fora de jogo). Definido por defeito na tecla "D"
  - "Golo/Celebração/Revisão" - cor azul - para quando a bola entra na baliza. Definido por defeito na tecla "S"

-- Regras de Utilização --
Sendo isto um processo manual deve-se definir algumas regras que toda a gente deve seguir para manter os dados os mais fiaveis possivel.
A ideia será cronometrar (com alguns segundos de margem de erro) o que se joga dentro dos 90 minutos inicialmente definidos para todos os jogos.
O utilizador deverá carregar nas teclas (ou clickar nos botões) de acordo com os acontecimentos do jogo. as teclas estão definidas por defeito como "W A S D" para os estados do jogo, "P" para iniciar/terminar a cronometragem, e Backspace para desfazer o ultimo segmento em caso de engano.

  - Carregar em iniciar no momento que o jogador toca na bola no pontapé inicial (não no apito) - isto começa automaticamente no estado "A seguir".
  - Carregar no estado "Bola fora do terreno de jogo" no momento que a bola saír do terreno de jogo. Apenas carregar no Estado "A seguir" quando a bola entra em jogo novamente (ex: momento em que o jogador larga a bola num lançamento lateral; momento em que o jogador toca na bola em pontapés de canto/baliza).
  - Carregar no estado "Arbitro interrompeu jogo" cada vez que o àrbitro interrompe o jogo e a bola deve ser reposta atravez da marcação de um livre, ou bola ao solo.  Apenas carregar no Estado "A seguir" quando a bola entra em jogo novamente (ex: momento em que o jogador toca na bola; momento em que a bola toca no chão depois do arbitro largar na bola ao solo).
  - Carregar no estado "Golo/Celebração/Revisão" cada vez que a bola entra na baliza. Apenas carregar no estado "A seguir" no momento em que o jogo é reatado após seguir a bola no meio campo, ou ser marcado o livre em caso de anulação.
  - Carregar em terminar no momento em que o arbitro apita para o final da primeira parte. Carregar em Iniciar novamente para iniciar a segunda parte, e depois voltar às regras acima. Carregar de novo em Terminar pela última vez quando o àrbitro apita para o final de jogo.

como fazer com substituições/atendimento médico?
será sempre incluído no estado atual, qualquer um dos 3 estados "nao ativos" pode ser maior ou menor dependendo de outros fatores.

-- Problemas / Limitações --
  - precisão mínima ao segundo, sendo que nunca um segmento deve ter menos que 1 segundo de duração. Os casos de duração menor que 1 segundo serão extremamente raros, e devem ser ajustados manualmente ao deixar correr 1 segundo antes de voltar a alterar o estado (exemplo: marcação de penaltys onde o estado ativo é menor que 1 segundo, deve ser ajustado para passar esse segundo no estado ativo)
  - dimensões do programa nao variáveis (pode nao parecer OK em diferentes tamanhos de ecrã)
  - (a adicionar...)
