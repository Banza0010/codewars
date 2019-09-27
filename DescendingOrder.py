def Descending_Order(num):
    num_list = [int(x) for x in str(num)]  #convert int to string list
    sort = sorted(num_list)[::-1]; #sort string list
    res = int("".join(map(str, sort))) #convert list to int 
    return int(str(res)) #return int 

//other better solutions 

def Descending_Order(num):
    s = str(num)
    s = list(s)
    s = sorted(s)
    s = reversed(s)
    s = ''.join(s)
    return int(s)

//even better
def Descending_Order(num):
    return int(''.join(sorted(str(num))[::-1]))
