	def tower_builder(n_floors):
    floors = []
    stars = 1
    space = n_floors - 1
    for floor in range(n_floors):
        floors.append(' ' * space + '*' * stars + space * ' ')
        #print(floors)
        stars += 2  
        space -= 1
    print(floors)    
    return floors
    
#test.assert_equals(tower_builder(1), ['*', ])
#test.assert_equals(tower_builder(2), [' * ', '***'])
#test.assert_equals(tower_builder(3), ['  *  ', ' *** ', '*****'])
