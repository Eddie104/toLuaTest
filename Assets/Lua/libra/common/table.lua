--table's number
function table.nums(t)
    local count = 0
    for k, v in pairs(t) do
        count = count + 1
    end
    return count
end

--table's keys
function table.keys(hashtable)
    local keys = {}
    for k, v in pairs(hashtable) do
        keys[#keys + 1] = k
    end
    return keys
end

--table's values
function table.values(hashtable)
    local values = {}
    for k, v in pairs(hashtable) do
        values[#values + 1] = v
    end
    return values
end

--
function table.merge(dest, src)
    for k, v in pairs(src) do
        dest[k] = v
    end
end

--
function table.walk(t, fn)
    for k,v in pairs(t) do
        fn(v, k)
    end
end

--table dump
function table.dump(t)
    for k, v in pairs(t) do
        logGreen("--->>>key:"..tostring(k).." --->>>value:"..tostring(v))
    end
end