const Project = require('../models').Project;
//updateAttributes for edit
//destroy for delete

module.exports = {
    index: (req, res) => {
        Project.findAll().then(projects => {
            res.render("project/index", {projects: projects});
        });

        // поглеждам в индекса, каква колекция идва. /
        // папката е views/project/
        // Рендерирам към изгледите и подавам листа от изгледи от базата данни  - projects

    },
    createGet: (req, res) => {
        res.render("project/create")
        // взимам съответния изглед папката е views/project/
    },
    createPost: (req, res) => {
        let body = req.body.project;

        Project.create(body).then(()=>{
            res.redirect("/")
        })
    },
    editGet: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            res.render("project/edit", {project:project})
        })

        // Декларирам ID намирам го от базата данни и рендерирам
        //или се подава обект {project:project} или project.dataValues
    },

    editPost: (req, res) => {
        // TODO
        let id = req.params.id;
        let body = req.body.project;

        Project.findById(id).then(project => {
            project.updateAttributes(body).then(()=>{
                res.redirect("/")
            })
        });
        // Second way
        // Project.findById(id).then(project => {
        //     project.title = body.title;
        //     project.description = body.description;
        //     project.budget = body.budget;
        //     project.save().then( () => res.redirect("/"));
        // })
    },

    deleteGet: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            res.render("project/delete", {project:project})
        })
        // almost the same as edit get

    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            project.destroy().then(()=>{
                res.redirect("/")
            })
        });
        // Second way
        // Project.findById(id).then(project => {
        //     return project.destroy()
        // }).then(()=>{
        //     res.redirect("/")
        // });
    }
};
