import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import GridList from '@material-ui/core/GridList';
import GridListTile from '@material-ui/core/GridListTile';
import GridListTileBar from '@material-ui/core/GridListTileBar';

const styles = theme => ({
  root: {
    display: 'flex',
    flexWrap: 'wrap',
    justifyContent: 'space-around',
    overflow: 'hidden',
  },
  gridList: {
    width: 500,
    height: 450,
    transform: 'translateZ(0)',
  },
  titleBar: {
    background:
      'linear-gradient(to bottom, rgba(0,0,0,0.7) 0%, ' +
      'rgba(0,0,0,0.3) 70%, rgba(0,0,0,0) 100%)',
  },
  icon: {
    color: 'white',
  },
});

function GameGridList(props) {
  const { classes } = props;

  return (
    <div className={classes.root}>
      <GridList cellHeight={200} spacing={1} className={classes.gridList}>
        {props.games.map(game => (
          <GridListTile
            key={game.imageUrl}
            cols={game.description ? 2 : 1}
            rows={game.description ? 2 : 1}
          >
            <img src={game.imageUrl} alt={game.title} />
            <GridListTileBar
              title={game.title}
              titlePosition="top"
              actionPosition="left"
              className={classes.titleBar}
            />
          </GridListTile>
        ))}
      </GridList>
    </div>
  );
}

GameGridList.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(GameGridList);
