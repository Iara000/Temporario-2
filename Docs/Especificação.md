### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade | Dificuldade |
|------|-----------------------------------------|----|---| 
|RF-001| Permitir que o administrador/usuários efetue Logon no sistema | ALTA | M |
|RF-002| Permitir que o administrador/usuários efetue Logoff no sistema | ALTA | M |
|RF-003| Permitir que o usuário encontre eletropostos disponíveis no Brasil | ALTA | A |
|RF-004| Ao final do cálculo, oferecer opção para o usuário compartilhar o resultado nas redes sociais | MEDIA | A |
|RF-005| Permitir que o usuário escolha o modelo do veículo (elétricos e a combustão) entre as opções cadastradas | MEDIA | M |
|RF-006??| Permitir que o administrador realize o cadastro de usuários | MEDIA | M |
|RF-007| Criar 3 tipos de calculadora para escolha do usuario | MÉDIA | B |
|RF-008| Permitir que o administrador realize o cadastro de veículos (elétricos e a combustão) | BAIXA | M |
|RF-009| Permitir recuperação de login| BAIXA | M |
|RF-010| Restrição de extensão do arquivo do upload de imagens| BAIXA | M|
|RF-011| Restrição de tamanho de arquivo do upload de imagens | BAIXA | M |
|RF-012| Realizar os cálculos necessários para comparação da autonomia e custo beneficio entre carros elétricos x combustão | BAIXA | B |
|RF-013| Cada campo do formulário deve ser validado quanto ao tipo de dado (inteiro/real/caractere) | BAIXA | B |
|RF-014| Criar menu para exibição das alternativas de cálculo | BAIXA | B |
|RF-015| Cada campo de formulário que possa gerar dúvida deve possuir um icone de ajuda | BAIXA | B |



### Requisitos não Funcionais

- RNF 01 - Padrões - Utilizar o SCRUM como metodologia de desenvolvimento
  |  |  |
  |--------|-------------------------|
  |Estímulo| Sistema com atraso no desenvolvimento devido à falta de aproximação e entendimento com o cliente |
  |Fonte do estímulo| Desenvolvedor de software |
  |Ambiente| Ambiente de desenvolvimento |
  |Artefato| Módulos do sistema |
  |Resposta| Equipe de desenvolvimento atuando em sprints e fazendo entregas de valor e pontuais para o cliente  |
  |Medida de resposta| Todos os entregáveis devem estar testados e de acordo com o cliente |
  
- RNF 02- Confiabilidade - As permissões de acesso ao sistema podem ser alteradas apenas pelo administrador de sistemas
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário sem permissões administrativas alterar as credenciais de outro usuário, impossibilitando-o de acessar sua conta |
  |Fonte do estímulo| Usuário administrativo |
  |Ambiente| Sistema |
  |Artefato| Módulo de informações cadastrais |
  |Resposta| O sistema não deve permitir que o usuário tenha acesso às credenciais de outro usuário, a não ser que este seja administrador |
  |Medida de resposta| Usuário sem permissão não consegue acessar a tela de usuários em nenhuma condição |

- RNF 03 - Usabilidade - Interface Intuitiva e Reativa
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário não deve se perder dentro do sistema |
  |Fonte do estímulo| Usuário |
  |Ambiente| Sistema com carga normal |
  |Artefato| Interfaces do sistema |
  |Resposta| A interface do sistema deve ser amigável para o usuário, conduzindo-o para o que deve ser feito |
  |Medida de resposta| Usuário deve saber 100% das vezes o que precisa ser feito e como deve ser feito |

- RNF 04- Compatibilidade- O sistema deve funcionar em todos os principais navegadores (Chrome, mozila e Edge)
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário possuir apenas um navegador em sua máquina e não conseguir acessar o sistema |
  |Fonte do estímulo| Usuário |
  |Ambiente| Sistema com carga normal |
  |Artefato| Sistema como um todo |
  |Resposta| O sistema deve ser compatível com todos os principais navegadores web |
  |Medida de resposta| 100% das tentativas de acesso ao sistema em qualquer navegador devem funcionar |

- RNF 05- Compatibilidade- O sistema deve ser responsivo para executar em dispositivos móveis
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário não conseguir utilizar as funcionalidades do sistema pelo celular |
  |Fonte do estímulo| Usuário |
  |Ambiente| Sistema com carga normal |
  |Artefato| Interfaces do sistema |
  |Resposta| A interface do sistema deve se adequar de acordo com o tamanho das telas do dispositivo |
  |Medida de resposta| As funcionalidades do sistema devem sempre estar disponíveis para os usuários em qualquer dispositivo |

- RNF 06- Desempenho- Deve processar requisições do usuário em no máximo 5s
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário deixar de utilizar o sistema devido à demora de resposta do servidor |
  |Fonte do estímulo| Usuário autenticado |
  |Ambiente| Sistema com carga normal |
  |Artefato| Sistema como um todo |
  |Resposta| O sistema como um todo processa as requisições e retorna os dados em até 5 segundos para o usuário |
  |Medida de resposta| Resposta do sistema com até 5 segundos de duração |

- RNF 07- Segurança- O sistema deve permitir ao usuário realizar a autenticação e autorização de entrada através de login e senha
  |  |  |
  |--------|-------------------------|
  |Estímulo| Usuário digitar suas credenciais e não conseguir acessar as funcionalidades do sistema |
  |Fonte do estímulo| Usuário não autenticado |
  |Ambiente| Sistema com carga normal |
  |Artefato| Módulo de autenticação e autorização |
  |Resposta| O usuário deve efetuar o login com sucesso e acessar as funcionalidades após a autorização |
  |Medida de resposta| Usuário autenticado e autorizado deve sempre estar apto a utilizar as funcionalidades do sistema |

### Restrições Arquiteturais

- R1: O front-end deve ser desenvolvido com a linguagem de programação JavaScript e para isso deve ser utilizado a biblioteca React na versão mais recente;
- R2: Para a padronização da interface deve ser seguido o guia de estilo do framework Bootstrap;
- R3: O mecanismo de autorização entre as APIs deverá ser feito por meio do JWT;
- R4: A aplicação deve ser hospedada no serviço de nuvem AWS;  

### Mecanismos Arquiteturais

|Análise | Design  | Implementação |
|--------|--------------------|----|
|Front-end |Biblioteca de programação | React|
|Front-end |Linguagem de programação | JavaScript|
|Front-end |Framework de folha de estilo | Bootstrap|
|Deploy |Plataforma de automatização de deploy | AWS|
|Back-end |Linguagem de programação | C# |
|Back-end |Framework | Node.js |
|Back-end |Gerenciador de tráfego |Amazon API Gateway |
|Autenticação |Padrão de formato para autenticação | JWT|
|Integração |Protocolo de comunicação | HTTP |
|Integração |Estilo de arquitetura | REST |
|Versionamento |Controle e armazenamento de código fonte | Github|
|Automação | Ferramenta de workflow | Figma, Lucidchart |
|Build |Ferramenta de build de componentes do software |NPM |
