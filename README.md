# ElginPayBridge_Demo_Winforms
Exemplo de utilização da dll ElginPay Bridge com C# e Windows Forms

![Badge](https://img.shields.io/static/v1?label=csharp&message=language&color=blue&style=for-the-badge&logo=csharp)
![Badge](https://img.shields.io/static/v1?label=.net6&message=framework&color=blue&style=for-the-badge&logo=.net)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Sobre o projeto 
  Este projeto é um exemplo que auxilia na implementação da dll E1_Bridge01.dll para comunicação com o smartPOS ElginPay e transações TEF no PDV windows com C# e windows forms.

Este projeto é mantido utilizando a linguagem CSharp com .Net6. 

## Recursos

- Teste de comunicação com o SmartPOS
- Venda com cartão no crédito (à vista e parcelado) e no débito
- Funções administrativas
- Impressão de extrato SAT e DANFECe


## Utilização
```sh
public const string PATH = @"E1_Bridge01.dll";

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConsultarStatus();

string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.ConsultarStatus());
```

## Suporte

- Discord: https://discord.gg/VjNMfGpg
- Github: https://github.com/ElginDeveloperCommunity/POS_Android_ElginPAY

## Sobre o SACFiscal & Automação
<img src="https://www.sacfiscal.com.br/biosac64.png">
Nossa empresa é especializada em suporte técnico e tributário para software houses.
Acesse: https://www.sacfiscal.com.br

| Tecnologias | Frameworks |
| ------ | ------ |
| C# | ZeusDFe <https://github.com/ZeusAutomacao/DFe.NET> UniNFe <https://github.com/Unimake/DFe> OpenAC <https://github.com/OpenAC-Net> |
| Delphi | ACBr <https://projetoacbr.com.br/> |
| Lazarus | ACBr <https://projetoacbr.com.br/> |
| PHP | SPEDNFe <https://github.com/nfephp-org/sped-nfe> |


## Curso de Arquitetura Fiscal em Software
ARQUITETURA FISCAL EM SOFTWARE <https://arquiteturafiscal.online>
<br>O mais completo treinamento de tributação e regras fiscais para programadores e software houses

## Licença

MIT

