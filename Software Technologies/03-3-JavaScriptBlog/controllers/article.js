const Article = require('../models').Article;
const User = require('../models').User;

module.exports = {
    createGet: (reg, res) => {
        res.render('article/create')
    },

    createPost: (reg, res) => {

        let articleArgs = reg.body;

        let errorMsg  = '';

        if (!reg.isAuthenticated()){
            errorMsg = 'You should be logged in to make articles!'
        } else if (!articleArgs.title){
            errorMsg = 'Invalid title!';
        } else if (!articleArgs.content){
            errorMsg = 'Invalid content!';
        }

        if (errorMsg) {
            res.render('article/create', {error: errorMsg});
            return;
        }
        articleArgs.authorId = reg.user.id;

        Article.create(articleArgs).then(article => {
            res.redirect('/');
        }).catch(err => {
            console.log(err.message);
            res.render('article/create', {error: err.message})
        })
    },
    details: (req, res) => {
        let id = req.params.id;
        Article.findById(id, {
            include: [
                {
                    model: User,
                }
            ]
        }). then(article => {
            res.render('article/details', article.dataValues);
        });
    }
};
