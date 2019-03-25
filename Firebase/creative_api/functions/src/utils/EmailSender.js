const nodemailer = require('nodemailer');
const email = require("./../Enum/EmailEnum");
const transporter = nodemailer.createTransport({
    service: 'gmail',
    auth: {
        user: 'creativepisystem@gmail.com',
        pass: 'creative2019'
    },
    tls:{
        rejectUnauthorized: false
    }
});
const from = "creativepisystem@gmail.com"
const body = {
    recovery: {
        subject: "Recuperação de Senha",
        text: "Ola , codigo de ativação é #AUTH#"
    }
}

module.exports = async function (to, type, info, success, error) {
    var mailOptions = {
        from: from,
        to: to
    }
    switch (type) {
        case email.RECOVERY:
            mailOptions.subject = body.recovery.subject;
            mailOptions.text = body.recovery.text.replace("#AUTH#", info.getAuth())
            break;
    }
    return await transporter.sendMail(mailOptions, function (e, info) {
        if (e) {
            console.error(e.message);
            error(e)
            return null;
        } else {
            console.log('success');
            success()
            return "ok"
        }
    });
}