import { EbseneTemplatePage } from './app.po';

describe('Ebsene App', function() {
  let page: EbseneTemplatePage;

  beforeEach(() => {
    page = new EbseneTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
