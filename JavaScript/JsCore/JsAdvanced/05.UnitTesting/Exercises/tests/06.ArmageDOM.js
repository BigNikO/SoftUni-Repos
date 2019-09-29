require('jsdom-global')();
const $ = require('jquery');
const { assert } = require('chai');
const nuke = require('../06.ArmageDOM');

describe('armageDOM', function() {
  before(() => (global.$ = $));

  beforeEach(() => {
    document.body.innerHTML = `<div id="target">
                <div class="nested target">
                    <p>This is some text</p>
                </div>
                <div class="target">
                    <p>Empty div</p>
                </div>
                <div class="inside">
                    <span class="nested">Some more text</span>
                    <span class="target">Some <span>more</span> text</span>
                </div>
            </div>`;
  });

  it('should do nothing if selectors are equal', () => {
    const expected = $('body').html();
    nuke('#target', '#target');
    const actual = $('body').html();
    assert.equal(actual, expected);
  });
});
