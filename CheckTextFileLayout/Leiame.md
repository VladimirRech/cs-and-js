# Projeto CheckTextFileLayout
Lê dois arquivos de texto para validar o layout de  um deles.

O arquivo de layout contém o código da seção e a largura esperada da linha bem como a posição no arquivo de destino que se encontra o código da seção.

Informar na execução se deseja realizar a contagem de linhas.

Verificar se todas as linhas da seção estão com a mesma largura e sinalizar quando alguma estiver fora.

Verificar se as linhas aparecem na ordem especificada no arquivo de seção.

# Propostas de entregas
## Entrega 1
Ler arquivo de layout.

Ler arquivo de texto checando de todos os layouts informados estão presentes e no tamanho esperado.

### Requisitos
1. Receber o nome dos arquivos por parâmetro de linha de comando.
2. A posição do indicador de layout é fixo nas três primeiras posições.
3. O conteúdo do arquivo de layout é fixo, sem mudanças.

## Entrega 2
Verificar se os layouts estão presentes na ordem informada no arquivo de layout.

Esta opção será passada pelo prompt de comando como argunmento.

## Entrega 3
Validar a existência dos arquivos.

Validar se o arquivo de layout está correto - contém as duas colunas esperadas para o layout. Esta opção está presente nos arquivos de configuração nas primeirars versões.

## Entrega 4
Passar por parâmetro o tamanho do código de início da linha - qual a posição e o tamanho. Esta opção está presente nos arquivos de configuração nas primeirars versões.