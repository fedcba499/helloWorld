from django.shortcuts import render

from django.http import HttpResponse

from django.http import Http404

from inventory.models import Item

# Create your views here.

def index(request):
    items = Item.objects.exclude(amount= 0)
    return render(request, 'inventory/index.html',{
        'items': items,
    })

    # return HttpResponse('<p> In Index view</p>')

def item_detail(request):    
    return HttpResponse('<p> in item_detail view with id</p>')


