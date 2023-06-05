# Extecamp-INF0991

| Lucas Mellone, Antony Valete, Pedro Ferreira          |
|-------------------------------------------------------|

Este trabalho tem como objetivo desenvolver habilidades de uso de sistema de controle de versão Git via ferramentas do Visual Studio Code. Este trabalho compõe a avaliação da disciplina INF0991.

## Working Tree de versionamento
## Rebase da branch
Executando o comando com a flag `--rebase`, é possível integrar patches de mudanças introduzidas em diferentes branches. Se tivermos uma branch `feature` com novas features, poderemos implementá-la realizando o rebase na `master`.
```shell
git checkout <feature>
git rebase master
```

## Logs de atualização
## License
>MIT License. You can fork, copy, use, modify, and distribute this repository without restriction.