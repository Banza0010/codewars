def friend(x):
    names = []                     #initialie new array
    for name in x:                  #loop thru names
        if len(name) == 4:          #check name length
            print name               #print names if length == 4 
            names.append(name)      #add names to new array 
    return names                    #return list

#test
#Test.assert_equals(friend(["Ryan", "Kieran", "Mark",]), ["Ryan", "Mark"])
