(function (root) {

    "use strict";

    //Objeto global
    root.SaluRepresentacao = root.SaluRepresentacao || {};

    //#region ESPAÇO DE NOMES
    root.SaluRepresentacao = {
        //#region variáveis globais
        varglobal: {
            novo: "#novo",
            editar: "#editar",
            excluir: "#excluir",
            exibir: "#exibir",
            indexConvenio: "#indexConvenio"
        },
        //#endregion

        TestaCPF: function (cpf) {
            if (typeof cpf !== "string") return false
            cpf = cpf.replace(/[\s.-]*/igm, '')
            if (
                !cpf ||
                cpf.length != 11 ||
                cpf == "00000000000" ||
                cpf == "11111111111" ||
                cpf == "22222222222" ||
                cpf == "33333333333" ||
                cpf == "44444444444" ||
                cpf == "55555555555" ||
                cpf == "66666666666" ||
                cpf == "77777777777" ||
                cpf == "88888888888" ||
                cpf == "99999999999"
            ) {
                return false
            }
            var soma = 0
            var resto
            for (var i = 1; i <= 9; i++)
                soma = soma + parseInt(cpf.substring(i - 1, i)) * (11 - i)
            resto = (soma * 10) % 11
            if ((resto == 10) || (resto == 11)) resto = 0
            if (resto != parseInt(cpf.substring(9, 10))) return false
            soma = 0
            for (var i = 1; i <= 10; i++)
                soma = soma + parseInt(cpf.substring(i - 1, i)) * (12 - i)
            resto = (soma * 10) % 11
            if ((resto == 10) || (resto == 11)) resto = 0
            if (resto != parseInt(cpf.substring(10, 11))) return false
            return true
        },


        maskScopo: function (scopo) {
            $(scopo).find(".cpf").mask("999.999.999-99");
            $(scopo).find(".cnpj").mask("99.999.999/9999-99");
            $(scopo).find(".numeroProcesso").mask("9999.99999-99/9999");
            $(scopo).find("cep").mask("99999-999");
            $(scopo).find(".fone").mask("(99) 99999-9999");
            $(scopo).find(".NEorOB").mask("99999");
        },


        mask: function () {
            $("cpf").mask("999.999.999-99");
            $(".cnpj").mask("99.999.999/9999-99");
            $(".numeroProcesso").mask("9999.99999-99/9999");
            //SIGECON.onlyNumber(".numeroentidade");

            $("cep").mask("99999-999");
            $(".fone").mask("(99) 9999-9999?9")
                .focusout(function (event) {
                    var target, phone, element;
                    target = (event.currentTarget) ? event.currentTarget : event.srcElement;
                    phone = target.value.replace(/\D/g, '');
                    element = $(target);
                    element.unmask();
                    if (phone.length > 10) {
                        element.mask("(99) 99999-999?9");
                    } else {
                        element.mask("(99) 9999-9999?9");
                    }
                });
            $(".NEorOB").mask("99999");
        }
    }

    SaluRepresentacao.maskScopo("form");

    //#endregion

    $("#UserNameNovo").on("blur", function () {

        var result = root.SIGECON.TestaCPF(this.value);
        var msg = "";
        if (result) {
            msg = "CPF válido!"
        }
        else {
            msg = "CPF inválido!"
        }
        document.querySelector("#msg").textContent = msg;
    })
})(window);






