# Neste projeto serão consumidas as seguintes Api's públicas

## Ibge:
1. Consultar Municípios por Estados
<br>GET https://servicodados.ibge.gov.br/api/v1/localidades/estados/RJ/municipios

2. Consultar Estados
<br>GET https://servicodados.ibge.gov.br/api/v1/localidades/estados

## ViaCep
1. Consultar Ceps
<br>GET https://viacep.com.br/ws/{cepSanitized}/json/

## ReceitaWS
1. Consultar Empresa por CNPJ
<br>GET https://www.receitaws.com.br/v1/cnpj/{cnpjSanitized}