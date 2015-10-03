{'application':{'type':'Application',
          'name':'Template',
    'backgrounds': [
    {'type':'Background',
          'name':'bgTemplate',
          'title':u'Standard Template with File->Exit menu',
          'size':(655, 411),
          'style':['resizeable'],

        'menubar': {'type':'MenuBar',
         'menus': [
             {'type':'Menu',
             'name':'menuFile',
             'label':'&File',
             'items': [
                  {'type':'MenuItem',
                   'name':'menuFileExit',
                   'label':'E&xit',
                   'command':'exit',
                  },
              ]
             },
             {'type':'Menu',
             'name':'menuConvert',
             'label':u'&Convert',
             'items': [
                  {'type':'MenuItem',
                   'name':'menuConvertCtoF',
                   'label':u'&Celsius to Fahrenheit',
                  },
                  {'type':'MenuItem',
                   'name':'menuConvertFtoC',
                   'label':u'&Fahrenheit to Celsius',
                  },
              ]
             },
         ]
     },
         'components': [

{'type':'Spinner', 
    'name':'spinFahr', 
    'position':(401, 140), 
    'max':100000, 
    'min':-100000, 
    'value':0, 
    },

{'type':'StaticText', 
    'name':'StaticText2', 
    'position':(403, 121), 
    'text':u'Frahrenheit:', 
    },

{'type':'StaticText', 
    'name':'StaticText1', 
    'position':(78, 121), 
    'text':u'Celsius:', 
    },

{'type':'TextField', 
    'name':'tfCel', 
    'position':(77, 140), 
    },

{'type':'Button', 
    'name':'btnFtoC', 
    'position':(222, 153), 
    'label':u'<<<Fahrenheit to Celsius', 
    },

{'type':'Button', 
    'name':'btnCtoF', 
    'position':(221, 123), 
    'label':u'Celsius to Fahrenheit >>>', 
    },

] # end components
} # end background
] # end backgrounds
} }
