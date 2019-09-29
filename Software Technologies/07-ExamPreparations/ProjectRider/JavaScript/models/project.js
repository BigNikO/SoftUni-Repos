const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    const Project = sequelize.define("Project", {
        title: {
            type: Sequelize.TEXT,
            required: true,
            allowNull:false
        },

        description: {
            type: Sequelize.TEXT,
            required: true,
            allowNull:false
        },

        budget: {
            type: Sequelize.INTEGER,
            required: true,
            allowNull:false
        }
    }, {
        timestamps: false
    });
    return Project;
};



// Създал съм полетата за таблицата за базада данни.
// Името на таблицата е проджект.
// Да не забравя timestamps: false
//при дефинирането на типовете Sequelize е с главна буква.
// !! Важно да не се забравя return Project: