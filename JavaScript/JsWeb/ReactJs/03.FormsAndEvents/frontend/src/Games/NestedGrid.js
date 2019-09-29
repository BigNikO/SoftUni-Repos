import React, { Fragment } from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import Typography from '@material-ui/core/es/Typography/Typography';
import { Divider } from '@material-ui/core';

const styles = theme => ({
  root: {
    flexGrow: 1,
  },
  paper: {
    padding: theme.spacing.unit,
    textAlign: 'center',
  },
  grow: {
    padding: theme.spacing.unit * 2,
  },
  divider: {
    margin: theme.spacing.unit,
  },
});

const FormRow = props => {
  const { classes, games } = props;

  return (
    <Fragment>
      {games.map((game, i) => (
        <Grid item xs={4} key={i}>
          <Paper className={classes.paper}>
            <div>{game.title}</div>
            <img src={game.imageUrl} alt={game.title} />
            <Paper className={classes.paper}>{game.description}</Paper>
          </Paper>
        </Grid>
      ))}
    </Fragment>
  );
};

FormRow.propTypes = {
  classes: PropTypes.object.isRequired,
};

function NestedGrid(props) {
  const { classes } = props;
  const pairs = props.games.reduce(function(result, value, index, array) {
    if (index % 3 === 0) result.push(array.slice(index, index + 3));
    return result;
  }, []);

  return (
    <div className={classes.root}>
      <Divider className={classes.divider} />
      <Typography variant="h2" color="inherit" className={classes.grow}>
        GAMES
      </Typography>
      <Divider />
      {pairs.map(pair => (
        <Grid container spacing={8}>
          <Grid container item xs={12} spacing={24}>
            <FormRow classes={classes} games={pair} />
          </Grid>
        </Grid>
      ))}
    </div>
  );
}

NestedGrid.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(NestedGrid);
